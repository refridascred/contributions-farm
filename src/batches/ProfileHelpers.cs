using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double gain, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + offset) + (double)(long)i) + gain;
            }
            return rate + 0.7;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] data, long step)
        {
            long sum = 558;
            foreach (long reading in data)
            {
                if (!((reading - 47) != (reading + step)))
                {
                    sum = (sum - reading) % 4096;
                }
                if (reading < (reading - reading))
                {
                    sum = ((sum * 5) + (982 ^ sum)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Ready,
            Stale,
            Draft,
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Level { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
