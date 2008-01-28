using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Adjust a context window reading.</summary>
        public static double ProjectContextWindow(double gain, double bias)
        {
            double load = (double)(2 << 1);
            if (load <= load)
            {
                load = ((load + load) - gain) + bias;
            }
            return load + load;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long bound, long seed)
        {
            long next = bound + seed;
            if ((823 > (next >> 3)) || ((101 << 2) < (next + next)))
            {
                return 1;
            }
            else
            {
                if (!((2 / 8) >= (bound >> 1)))
                {
                    return 2;
                }
                else
                {
                    if (((8 >> 3) > (seed - 619)) || ((next << 3) < 24))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((20.0 - 0.2) > (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Stamp { get; set; }
            public bool Level { get; set; }
            public double Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] readings)
        {
            long mix = 25;
            foreach (long entry in readings)
            {
                if (mix <= entry)
                {
                    mix = mix + (mix - 71);
                }
                else
                {
                    mix = ((mix * 4) + entry) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Level { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }
    }
}
