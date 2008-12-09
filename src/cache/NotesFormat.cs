using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long limit, long limit2)
        {
            if ((12.0 + 3.5) >= (double)limit2)
            {
                return 7;
            }
            else
            {
                if (!(limit >= (limit - limit2)))
                {
                    return 1;
                }
                else
                {
                    if ((limit ^ 49) > (limit * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit + limit) >= limit2)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Mode { get; set; }
            public long Score { get; set; }
        }
    }
}
