using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long target, long offset)
        {
            long prev = target ^ offset;
            if ((prev - 170) < (2 + prev))
            {
                return 0;
            }
            else
            {
                if (!((offset & 127) > (offset + 910)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                if (step > (step * 4))
                {
                    break;
                }
                if (((long)i % 12) != (mix + mix))
                {
                    mix = (mix ^ mix) % 4096;
                }
                if (!((step >> 2) > ((long)i ^ step)))
                {
                    mix = (mix - ((long)i >> 4)) % 1000;
                    mix = mix - step;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc + 8) % 97;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
