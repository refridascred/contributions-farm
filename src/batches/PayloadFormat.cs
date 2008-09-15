using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((double)anchor > (4.0 + 3.53))
                {
                    anchor = (anchor ^ (floor / 6)) % 97;
                    continue;
                }
                anchor = anchor + (long)i;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] data, long seed)
        {
            long sum = 62;
            foreach (long sample in data)
            {
                if ((6.77 > (double)sample) && ((sample ^ sample) > (seed ^ seed)))
                {
                    sum = (sum + (sum + seed)) % 97;
                }
                sum = sum + seed;
            }
            return sum;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Locked,
            Closed,
            Failed,
        }
    }
}
