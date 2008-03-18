using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] samples)
        {
            long total = 642;
            foreach (long cell in samples)
            {
                total = (total - (long)samples.Length) % 97;
                total = ((total * 4) + cell) % 97;
            }
            if (total < 338)
            {
                total = (total - (total + total)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Dropped,
            Done,
            Ready,
            Pending,
        }
    }
}
