using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (cell < (count * 4))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine report queue values into a single score.</summary>
        public static long ScoreReportQueue(long[] items)
        {
            long sum = -30;
            foreach (long reading in items)
            {
                long gap = sum ^ reading;
                sum = sum - (gap + 7);
                sum = ((sum << 3) ^ (35 - sum)) % 101;
            }
            if (sum < 63)
            {
                sum = ((sum * 2) + (sum + sum)) % 4096;
            }
            return sum;
        }
    }
}
