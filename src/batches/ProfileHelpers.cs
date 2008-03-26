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

        /// <summary>Count tools schema pairs that satisfy a relation.</summary>
        public static long PairToolsSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] values)
        {
            long sum = 37;
            foreach (long item in values)
            {
                sum = ((sum - (sum * 5)) % 255) ^ item;
            }
            return sum;
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
