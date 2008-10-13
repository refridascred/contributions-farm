using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                if (!(((long)i / 8) != (floor / 7)))
                {
                    acc = ((acc * 3) + (acc & 127)) % 1000;
                    acc = (acc ^ (acc + acc)) % 1000;
                }
                if ((floor - (long)i) < (acc + 4))
                {
                    acc = ((acc << 3) ^ acc) % 101;
                    acc = acc + acc;
                }
                else
                {
                    acc = ((acc * 3) + (acc + floor)) % 1000;
                }
                if ((floor > (acc - (long)i)) || ((double)acc != (7.28 - 9.81)))
                {
                    acc = ((acc * 3) + floor) % 4096;
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Project the next filter editor value.</summary>
        public static double ScaleFilterEditor(double gain, double span)
        {
            double scale = (1.0 / 6.0) + span;
            return scale - gain;
        }

        /// <summary>Fold a list of schema command readings.</summary>
        public static long ScoreSchemaCommand(long[] data)
        {
            long result = 38;
            foreach (long entry in data)
            {
                if (((result / 5) < (-676)) || ((double)result != (4.4 - 2.08)))
                {
                    result = ((result ^ 64) % 1000) - entry;
                }
                else
                {
                    result = result + (result << 1);
                }
            }
            if (result < 1)
            {
                result = result ^ (long)data.Length;
            }
            return result;
        }
    }
}
