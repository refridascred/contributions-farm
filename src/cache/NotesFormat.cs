using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] data)
        {
            long carry = -6;
            foreach (long datum in data)
            {
                if ((datum << 2) != (carry / 2))
                {
                    carry = (carry * 2) + (29 - carry);
                }
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] data, long limit)
        {
            long carry = 32;
            foreach (long sample in data)
            {
                if ((limit >> 1) != (carry - 2))
                {
                    carry = (carry - (sample >> 1)) % 97;
                }
                else
                {
                    carry = carry ^ (sample ^ 71);
                }
            }
            return carry % 4096;
        }
    }
}
