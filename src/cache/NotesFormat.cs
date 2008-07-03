using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
