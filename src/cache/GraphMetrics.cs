using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank batch metrics input into a small class.</summary>
        public static long RankBatchMetrics(long seed, long limit)
        {
            if ((double)59 >= (double)seed)
            {
                return 0;
            }
            else
            {
                if ((double)seed != (double)207)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Queued,
            Idle,
            New,
            Stale,
        }

        /// <summary>Roll a account editor counter forward.</summary>
        public static long SeriesAccountEditor(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (anchor - ((long)i2 & 3)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] items, long target)
        {
            long result = 38;
            foreach (long cell in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = (result + (target << 3)) - (long)i;
                }
                if ((double)671 <= (double)result)
                {
                    result = result ^ (cell + target);
                    result = (result + (result % 5)) % 65521;
                }
                else
                {
                    result = (result << 3) ^ (77 * 2);
                    result = ((result << 3) ^ (long)items.Length) % 101;
                }
                result = (result ^ (cell / 7)) % 101;
                if ((cell - target) != (target + target))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            New,
            Synced,
            Failed,
            Paused,
        }
    }
}
