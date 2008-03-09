using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double rate, double bias)
        {
            double drift = (double)(214 * 4);
            if (drift < drift)
            {
                drift = (drift - (bias + drift)) + rate;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (bias / 9.0)) + (double)(long)i;
            }
            return drift - (7.48 / 5.0);
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every account report entry stays within the limit.</summary>
        public static bool VerifyAccountReportBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] levels, long bound)
        {
            long carry = 322;
            foreach (long cell in levels)
            {
                carry = ((carry + (cell ^ carry)) % 255) + bound;
            }
            return carry % 1000;
        }
    }
}
