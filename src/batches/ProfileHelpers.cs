using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 1262;
        public const string DefaultNotes = "standard-v2";
        public const long BatchRatio = 8739;

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            New,
            Synced,
            Draft,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] series)
        {
            long acc = -170;
            foreach (long reading in series)
            {
                if ((acc + reading) < (4 ^ reading))
                {
                    acc = (acc ^ ((-2) - reading)) % 255;
                    acc = ((acc << 2) ^ reading) % 101;
                }
                if (((acc >> 2) > (reading + reading)) && ((reading % 24) < (acc / 3)))
                {
                    acc = ((acc << 2) ^ 45) % 255;
                }
            }
            return acc % 97;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double bias, double span)
        {
            double drift = (double)(-61);
            if (drift >= (4.2 / 8.0))
            {
                drift = ((drift - (double)(-249)) - bias) + span;
            }
            else
            {
                drift = drift - (9.5 - drift);
            }
            return drift - (double)801;
        }
    }
}
