using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every commits editor entry stays within the limit.</summary>
        public static bool CheckCommitsEditorBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                state = (state ^ 4) % 255;
                state = (state << 3) ^ (state & 7);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Pending,
            Synced,
            Dropped,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((((long)i & 1) > (offset ^ 2)) && ((double)result != (double)(long)i))
                {
                    result = (result << 3) ^ result;
                    break;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double scale, double span)
        {
            double rate = (double)10;
            if (rate >= (scale * 3.57))
            {
                rate = (rate - (double)8) - span;
            }
            else
            {
                rate = rate + 1.06;
            }
            return rate + (double)362;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryTimeout = "fallback-v2";
        public const long RetryCommand = 909;
        public const long BurstCommand = 683;
    }
}
