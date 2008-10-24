using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!(1.7 >= (double)cell))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of buffer token readings.</summary>
        public static long CompareBufferTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((long)data.Length >= (step + 801))
                {
                    seen = (seen + 3) - reading;
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
