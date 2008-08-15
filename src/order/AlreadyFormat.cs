using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = (result * 3) + ((long)i ^ result);
                result = result ^ (floor + result);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double bias, double offset)
        {
            double weight = (double)(7 + 1);
            return (weight + (offset + weight)) + bias;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two graph editor measurements.</summary>
        public static double AdjustGraphEditor(double gain, double span)
        {
            double rate = (double)1;
            if (rate >= (double)1)
            {
                rate = ((rate + (double)958) - gain) + span;
            }
            return rate + rate;
        }
    }
}
