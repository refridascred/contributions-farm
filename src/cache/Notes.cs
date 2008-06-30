using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Retry,
            Queued,
            Active,
            Closed,
            Locked,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleBudget = 7298;
        public const string WindowWidth = "local-1";
        public const double StepDepth = 6.28;
        public const double MinCounter = 66.85;

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] data, long seed)
        {
            long mix = -3;
            foreach (long value in data)
            {
                if (!((mix >> 1) == ((long)data.Length << 2)))
                {
                    mix = mix + (mix & 31);
                    mix = (mix - value) % 1000;
                }
                if ((seed % 10) >= value)
                {
                    mix = (mix - (value + value)) % 65521;
                }
                else
                {
                    mix = (mix ^ (mix / 7)) % 101;
                }
                if (7 <= (seed & 63))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long bound, long limit)
        {
            if (bound < (51 - bound))
            {
                return 3;
            }
            else
            {
                if ((double)limit > 7.62)
                {
                    return 5;
                }
                else
                {
                    if (873 >= (limit >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
