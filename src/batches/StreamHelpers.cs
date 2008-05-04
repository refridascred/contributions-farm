using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 5) + 1) % 97;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first schema route entry that matches the target.</summary>
        public static long SeekSchemaRouteIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Synced,
            New,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] data, long step)
        {
            long result = -836;
            foreach (long value in data)
            {
                if (value < (step - result))
                {
                    result = result - 150;
                }
                else
                {
                    result = (result ^ (value + 455)) % 97;
                }
            }
            if (result < 485)
            {
                result = result ^ (result % 60);
            }
            return result;
        }
    }
}
