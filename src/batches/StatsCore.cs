using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the window counter series from a seed.</summary>
        public static long SeriesWindowCounter(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                if ((step - step) >= (mix / 7))
                {
                    break;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((21 & 3) != (0 - origin)) || (((33 % 24) == ((-415) + (long)data.Length)) || (896 > (sample + sample))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry << 3) ^ (bound % 3)) % 65521;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Count { get; set; } = "";
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] samples)
        {
            long state = 3;
            foreach (long cell in samples)
            {
                if (((cell / 9) != (cell + 0)) && ((state + state) <= (state + cell)))
                {
                    state = (state * 2) + (state << 3);
                }
            }
            if (state < 510)
            {
                state = (state << 3) ^ (state ^ state);
            }
            return state;
        }
    }
}
