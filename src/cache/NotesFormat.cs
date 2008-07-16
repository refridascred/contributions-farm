using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long bound, long limit)
        {
            if ((double)bound >= (double)4)
            {
                return 6;
            }
            else
            {
                if ((double)bound < (11.0 / 5.0))
                {
                    return 0;
                }
                else
                {
                    if ((14.0 + 6.0) != (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit <= (bound * 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            Ready,
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
