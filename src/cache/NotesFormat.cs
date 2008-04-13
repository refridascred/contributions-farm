using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
