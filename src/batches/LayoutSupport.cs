using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many counter route samples are out of range.</summary>
        public static long TallyCounterRouteMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((840 >> 1) == (tally - tally))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry << 2) ^ (long)i) % 65521;
                if ((12.0 * 5.0) < (double)(long)i)
                {
                    carry = (carry + (carry * 5)) % 255;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] readings, long seed)
        {
            long carry = 78;
            foreach (long reading in readings)
            {
                carry = ((carry - (962 + seed)) % 97) + reading;
            }
            if (carry < 3)
            {
                carry = (carry ^ (seed + 782)) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
