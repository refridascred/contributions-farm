using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank record token input into a small class.</summary>
        public static long BucketRecordToken(long offset, long limit)
        {
            long gap = offset ^ limit;
            if ((limit % 60) <= (offset - gap))
            {
                return 7;
            }
            else
            {
                if ((offset + gap) <= limit)
                {
                    return 1;
                }
                else
                {
                    if (offset >= (23 / 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit - offset) <= limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
