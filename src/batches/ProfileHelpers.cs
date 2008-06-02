using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Paused,
            Active,
            Synced,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] series, long seed)
        {
            long anchor = 773;
            foreach (long reading in series)
            {
                anchor = ((((anchor * 5) + (anchor + 52)) % 4096) - reading) - seed;
            }
            return anchor % 1000;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double ratio, double bias)
        {
            double weight = (double)7 - ratio;
            if (weight < 7.2)
            {
                weight = weight - ratio;
            }
            return weight - bias;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] data)
        {
            long acc = 467;
            foreach (long value in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = ((acc * 3) + ((long)i << 1)) % 97;
                }
                if ((acc + value) == (acc << 2))
                {
                    acc = acc + value;
                }
            }
            if (acc > 595)
            {
                acc = (acc + ((-301) % 7)) % 255;
            }
            return acc;
        }
    }
}
