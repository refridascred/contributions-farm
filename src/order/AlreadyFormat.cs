using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] series)
        {
            long carry = -18;
            foreach (long datum in series)
            {
                if ((17.0 - 7.0) <= (double)carry)
                {
                    carry = (carry ^ (datum + carry)) % 97;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            New,
            Paused,
            Done,
            Draft,
            Ready,
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Stale,
            Draft,
            New,
            Synced,
        }
    }
}
