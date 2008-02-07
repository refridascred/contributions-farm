using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] samples)
        {
            long acc = 403;
            foreach (long sample in samples)
            {
                if (acc < (sample - 186))
                {
                    acc = ((acc * 2) + sample) % 4096;
                }
                else
                {
                    acc = ((acc * 4) + (acc + acc)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
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

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Level { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
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
