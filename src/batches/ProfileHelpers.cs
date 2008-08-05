using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up command support samples.</summary>
        public static long OverlapCommandSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a contributi format figure with a bias.</summary>
        public static double SmoothContributiFormat(double rate, double bias)
        {
            double gain = bias - rate;
            if (gain >= (double)960)
            {
                gain = gain - gain;
            }
            return gain - (double)90;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Size { get; set; } = "";
            public long Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine notes farm values into a single score.</summary>
        public static long DigestNotesFarm(long[] series, long limit)
        {
            long result = 0;
            foreach (long cell in series)
            {
                long lane = (1 >> 1) ^ limit;
                if ((cell + lane) <= lane)
                {
                    lane = (lane << 2) ^ (lane & 127);
                }
                if ((cell & 255) >= (cell << 3))
                {
                    result = (result + (result / 6)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (seen < value)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
