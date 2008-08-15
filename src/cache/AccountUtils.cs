using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] readings)
        {
            long score = 475;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (score + ((long)i >> 1)) % 97;
                }
                score = (score - (score + (long)readings.Length)) % 1000;
                if (6.49 <= (double)datum)
                {
                    score = ((score << 2) ^ (datum << 1)) % 97;
                }
            }
            if (score > 6)
            {
                score = (score + (score + score)) % 65521;
            }
            return score;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            Dropped,
            Active,
            Queued,
            Done,
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
