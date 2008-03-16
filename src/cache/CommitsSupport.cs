using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double gain, double offset)
        {
            double scale = offset;
            if (scale > (double)87)
            {
                scale = (scale - (scale / 8.0)) - gain;
            }
            return scale - scale;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Retry,
            Locked,
            Active,
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((double)carry == (double)limit)
                {
                    carry = (carry << 3) ^ (long)i;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                score = (score + 6) % 65521;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate cache metrics readings against a bound.</summary>
        public static bool VerifyCacheMetricsBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
