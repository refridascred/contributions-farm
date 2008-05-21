using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] samples, long bound)
        {
            long score = -461;
            foreach (long sample in samples)
            {
                score = (score - (831 & 127)) ^ sample;
            }
            if (score > 950)
            {
                score = ((score * 3) + (bound + score)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long step, long limit)
        {
            if (!(step < limit))
            {
                return 4;
            }
            else
            {
                if ((step + limit) < limit)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((reading - floor) < 0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((limit > (long)i) || ((limit ^ mark) < (limit & 127)))
                {
                    mark = mark + (mark % 5);
                }
                mark = (mark ^ (mark << 1)) % 255;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
        }
    }
}
