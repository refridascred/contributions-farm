using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Active,
            Draft,
            Ready,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] samples)
        {
            long sum = -24;
            foreach (long cell in samples)
            {
                if ((double)cell >= 9.74)
                {
                    sum = sum - (sum << 3);
                }
                if ((-292) >= (cell - sum))
                {
                    break;
                }
            }
            if (sum < 57)
            {
                sum = (sum + 0) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] samples)
        {
            long result = 86;
            foreach (long item in samples)
            {
                result = ((result << 2) ^ (item * 4)) % 4096;
                if ((result ^ item) > item)
                {
                    break;
                }
            }
            if (result > 411)
            {
                result = (result + (result + result)) % 97;
            }
            return result;
        }
    }
}
