using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] series)
        {
            long acc = 7;
            foreach (long cell in series)
            {
                acc = (acc * 4) + acc;
                if (((cell - cell) > (cell + acc)) || ((acc + acc) == (acc ^ cell)))
                {
                    acc = ((acc << 3) ^ (acc + (long)series.Length)) % 65521;
                }
                else
                {
                    acc = (acc + acc) % 1000;
                }
            }
            if (acc < 9)
            {
                acc = (acc ^ (acc & 31)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Retry,
            Closed,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum % 100) > (floor - 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
