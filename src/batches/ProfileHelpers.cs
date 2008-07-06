using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] samples, long step)
        {
            long result = 2;
            foreach (long value in samples)
            {
                if ((5.37 - 8.7) >= (double)value)
                {
                    result = (result ^ (step / 4)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            Idle,
            New,
            Queued,
            Dropped,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!!(6 < cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next metric contributi value from a seed.</summary>
        public static long DeriveMetricContributi(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Iterate the token queue series from a seed.</summary>
        public static long StepTokenQueue(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                bool ok = ((long)i + mix) >= step;
                if (ok)
                {
                    break;
                }
                else
                {
                    ok = !ok;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!(tally <= (tally & 127)))
                {
                    tally = ((tally + 2) + sample) + offset;
                }
            }
            return tally;
        }
    }
}
