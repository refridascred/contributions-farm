using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long floor, long floor2)
        {
            if (((floor + floor) == (832 * 3)) || (floor <= (floor << 1)))
            {
                return 7;
            }
            else
            {
                if ((double)floor2 > (6.0 - 10.0))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank session stats input into a small class.</summary>
        public static long BucketSessionStats(long step, long seed)
        {
            if (((seed >> 5) != (seed * 5)) || (seed <= (seed + seed)))
            {
                return 2;
            }
            else
            {
                if ((double)93 == (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((step <= (seed ^ seed)) && ((double)seed > (8.8 - 2.4)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Match up schema editor samples.</summary>
        public static long PairSchemaEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
