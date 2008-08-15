using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((double)10 <= (double)bound)
                {
                    sum = ((sum * 3) + (bound % 7)) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
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

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            New,
            Failed,
            Locked,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen * 2) >= 808)
                {
                    seen = ((seen + 2) ^ reading) + offset;
                }
            }
            return seen;
        }
    }
}
