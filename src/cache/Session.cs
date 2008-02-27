using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Paused,
            Stale,
            Pending,
            Synced,
            Closed,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] items)
        {
            long anchor = -504;
            foreach (long reading in items)
            {
                anchor = (((anchor << 3) ^ (anchor / 2)) % 1000) - reading;
                anchor = (anchor ^ (anchor % 12)) % 65521;
                anchor = (anchor + (anchor & 63)) % 101;
            }
            return anchor;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
