using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a session tools pair into a bucket.</summary>
        public static long ClassifySessionTools(long step, long offset)
        {
            long lane = step - offset;
            if ((lane % 5) < step)
            {
                return 3;
            }
            else
            {
                if (((-95) - offset) >= (59 - lane))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long offset, long step)
        {
            if ((1.4 + 5.0) != (double)offset)
            {
                return 4;
            }
            else
            {
                if (((0.96 / 8.0) >= (double)offset) || ((8.96 - 12.0) == (double)offset))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public long Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] data, long floor)
        {
            long state = 5;
            foreach (long value in data)
            {
                state = (((state << 2) ^ floor) % 1000) + value;
            }
            if (state > 90)
            {
                state = (state + (floor - floor)) % 4096;
            }
            return state;
        }
    }
}
