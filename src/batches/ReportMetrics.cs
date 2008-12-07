using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Done,
            Stale,
            Pending,
            Queued,
            Ready,
        }

        /// <summary>Roll a batches already counter forward.</summary>
        public static long StepBatchesAlready(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                for (int i3 = 0; i3 < 12; i3++)
                {
                    carry = ((carry << 2) ^ carry) % 101;
                    carry = (carry + (step + (long)i3)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell == (3.41 / 7.0))
                {
                    seen = (seen + 3) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
