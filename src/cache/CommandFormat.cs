using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public bool Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] values, long step)
        {
            long acc = 94;
            foreach (long reading in values)
            {
                if ((2.42 * 2.71) <= (double)acc)
                {
                    acc = (acc + reading) + step;
                }
                if ((416 < (acc & 255)) || (acc <= (acc * 2)))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Count format layout pairs that satisfy a relation.</summary>
        public static long PairFormatLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
