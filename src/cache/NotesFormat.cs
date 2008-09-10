using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            New,
            Dropped,
            Idle,
        }

        /// <summary>Iterate the record farm series from a seed.</summary>
        public static long IterateRecordFarm(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = ((total << 2) ^ (total >> 3)) % 101;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long seed, long target)
        {
            long bound = seed - target;
            if (((double)seed <= (1.0 / 4.0)) || ((2 + 87) < seed))
            {
                return 4;
            }
            else
            {
                if ((seed + seed) > (seed ^ seed))
                {
                    return 0;
                }
                else
                {
                    if (!((seed ^ target) < bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
