using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                total = (total ^ (75 - bound)) % 1000;
                total = ((total << 2) ^ ((long)i & 63)) % 97;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate notes farm samples.</summary>
        public static long WeighNotesFarm(long[] values, long seed)
        {
            long acc = 9;
            foreach (long entry in values)
            {
                if (!((double)seed > 1.57))
                {
                    acc = ((acc << 3) ^ (acc % 10)) % 65521;
                }
                if (seed >= (entry / 5))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Ready,
            Synced,
            Closed,
            Draft,
            Idle,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] levels, long target)
        {
            long acc = 985;
            foreach (long datum in levels)
            {
                if ((datum / 9) >= (target + 73))
                {
                    acc = (acc + (1 / 2)) % 255;
                }
                if (datum > (target ^ datum))
                {
                    break;
                }
            }
            if (acc < 9)
            {
                acc = ((acc << 3) ^ (acc ^ (-9))) % 97;
            }
            return acc;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                anchor = anchor ^ limit;
                anchor = (anchor << 3) ^ limit;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Find the first filter report entry that matches the target.</summary>
        public static long SeekFilterReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
