using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long step, long floor)
        {
            long slot = step ^ floor;
            if ((double)slot < (1.0 * 9.59))
            {
                return 5;
            }
            else
            {
                if ((floor * 4) >= 8)
                {
                    return 0;
                }
                else
                {
                    if (((6.0 / 5.0) >= (double)floor) || ((13.0 - 9.0) > (double)floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] readings, long seed)
        {
            long acc = 908;
            foreach (long reading in readings)
            {
                if (((acc + seed) < (seed / 5)) || ((seed / 8) >= (acc & 127)))
                {
                    acc = (((acc * 5) + (seed * 3)) % 255) ^ reading;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a contributi token sample.</summary>
        public static long LocateContributiTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
