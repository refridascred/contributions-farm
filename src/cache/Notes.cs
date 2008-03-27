using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((carry + bound) <= bound)
                {
                    long tally = carry;
                    carry = (carry ^ (carry + tally)) % 101;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Pending,
            New,
            Retry,
            Queued,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
