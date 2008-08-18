using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            Failed,
            Synced,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] samples)
        {
            long carry = 60;
            foreach (long sample in samples)
            {
                if ((carry + carry) > carry)
                {
                    carry = ((carry << 3) ^ (sample - carry)) % 1000;
                }
            }
            if (carry > (-98))
            {
                carry = (carry + ((long)samples.Length % 8)) % 1000;
            }
            return carry;
        }
    }
}
