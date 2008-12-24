using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                if (((mix + mix) == (bound ^ bound)) || ((mix % 5) < (bound & 31)))
                {
                    mix = (mix * 3) + ((long)i - mix);
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (((mix * 2) + mix) % 101) ^ (long)i2;
                    mix = (mix + (mix % 24)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] readings)
        {
            long mix = -593;
            foreach (long datum in readings)
            {
                if (!((datum >> 1) > datum))
                {
                    mix = (mix << 2) ^ (datum + datum);
                }
            }
            return mix % 65521;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long bound, long offset)
        {
            if (!(960 < (bound & 15)))
            {
                return 3;
            }
            else
            {
                if (!((bound >> 5) == (462 >> 5)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
