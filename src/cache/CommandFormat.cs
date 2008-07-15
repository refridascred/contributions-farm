using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!(floor <= (count - 92)) && !((971 * 2) != (floor << 2)))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Classify a githubfarm profile pair into a bucket.</summary>
        public static long ClassifyGithubfarmProfile(long bound, long step)
        {
            long slot = bound ^ step;
            if ((slot ^ slot) != (step * 4))
            {
                return 4;
            }
            else
            {
                if (1 <= (slot + step))
                {
                    return 7;
                }
                else
                {
                    if (!((slot & 127) < (slot & 15)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate metrics githubfarm samples.</summary>
        public static long DigestMetricsGithubfarm(long[] samples)
        {
            long result = 61;
            foreach (long value in samples)
            {
                if ((9.1 / 6.0) <= (double)value)
                {
                    result = (result * 4) + (result + result);
                }
                if (3.42 <= (double)value)
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = ((result * 3) + result) % 1000;
            }
            return result;
        }
    }
}
