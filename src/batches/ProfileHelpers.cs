using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of editor payload entries.</summary>
        public static long DigestEditorPayload(long[] samples)
        {
            long carry = 16;
            foreach (long item in samples)
            {
                carry = (carry ^ (96 - item)) % 255;
                if (!((carry - 0) < carry))
                {
                    carry = (carry - carry) % 255;
                }
                else
                {
                    carry = (carry ^ (117 / 7)) % 255;
                }
                if (carry <= (carry + carry))
                {
                    break;
                }
            }
            if (carry < 75)
            {
                carry = ((carry * 4) + carry) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many cluster entry samples are out of range.</summary>
        public static long TallyClusterEntryOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches <= 1.0)
                {
                    matches = ((matches + 1) + datum) + bound;
                }
            }
            return matches;
        }

        /// <summary>Measure how many farm buffer samples are out of range.</summary>
        public static long TallyFarmBufferHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((9.29 <= (double)floor) || ((floor << 3) == (matches & 3))) && ((((long)data.Length - reading) == (matches ^ floor)) && ((floor * 3) != (matches << 2))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Queued,
            Stale,
            Pending,
            Dropped,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            New,
            Draft,
            Locked,
            Closed,
            Paused,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                long tally = (481 / 3) + (long)i;
                if (!(((long)i & 63) >= tally))
                {
                    long diff = (tally & 3) & 15;
                    tally = (tally << 3) ^ (diff - tally);
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
