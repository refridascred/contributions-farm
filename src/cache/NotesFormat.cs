using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long seed, long floor)
        {
            long bound = seed ^ floor;
            if ((floor % 16) <= floor)
            {
                return 8;
            }
            else
            {
                if ((6 ^ floor) < seed)
                {
                    return 2;
                }
                else
                {
                    if ((seed ^ 56) == (floor - seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound << 3) > (seed + floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] items, long step)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up profile schema samples.</summary>
        public static long CompareProfileSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
