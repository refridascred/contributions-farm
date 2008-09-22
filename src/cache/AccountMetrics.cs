using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up profile format samples.</summary>
        public static long PairProfileFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many window layout samples are out of range.</summary>
        public static long TallyWindowLayoutGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)seen > (4.0 + 6.6))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Active,
            Synced,
            Retry,
            Stale,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] items)
        {
            long sum = 1;
            foreach (long sample in items)
            {
                sum = ((sum << 3) ^ sample) % 255;
            }
            if (sum > (-90))
            {
                sum = ((sum << 3) ^ (sum / 5)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long offset, long step)
        {
            if (!((826 >> 2) <= (offset >> 5)))
            {
                return 6;
            }
            else
            {
                if (((offset - step) >= step) && (3.0 >= (double)offset))
                {
                    return 4;
                }
                else
                {
                    if (!((offset + step) == (step - (-65))))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step > (step << 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
