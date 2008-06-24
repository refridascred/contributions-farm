using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] series, long step)
        {
            long result = 9;
            foreach (long datum in series)
            {
                result = ((result << 2) ^ (datum >> 2)) - step;
            }
            return result;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double scale, double floor)
        {
            double mean = 1.0 / 5.0;
            for (int i = 0; i < 5; i++)
            {
                mean = (((mean - 5.15) - (double)(long)i) - scale) + floor;
            }
            return mean + (double)66;
        }

        /// <summary>Match up session schema samples.</summary>
        public static long PairSessionSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Level { get; set; }
            public long Label { get; set; }
            public bool Count { get; set; }
            public long Limit { get; set; }
        }
    }
}
