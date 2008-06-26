using System;

namespace Common.Utilities
{
    /// <summary>Booking format helpers.</summary>
    public static class BookingFormat
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Synced,
            Closed,
            Locked,
        }

        /// <summary>Count stats batch pairs that satisfy a relation.</summary>
        public static long MatchStatsBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Draft,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading + 762) == ((long)samples.Length << 1))
                {
                    matches = (matches + 3) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
