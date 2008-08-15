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

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] series, long seed)
        {
            long anchor = 434;
            foreach (long datum in series)
            {
                if ((seed + (-579)) < seed)
                {
                    anchor = (anchor ^ (-7)) % 101;
                }
                if ((seed * 3) <= (seed % 8))
                {
                    anchor = (anchor - (datum & 7)) % 65521;
                }
                else
                {
                    anchor = (anchor << 3) ^ (datum ^ anchor);
                }
            }
            return anchor;
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
