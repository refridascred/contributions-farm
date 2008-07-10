using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit already route readings against a rule.</summary>
        public static long AuditAlreadyRouteGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally & 255) <= (tally + tally))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Adjust a payload queue reading.</summary>
        public static double BlendPayloadQueue(double scale, double offset)
        {
            double rate = offset;
            if (rate > rate)
            {
                rate = rate + (double)88;
            }
            else
            {
                rate = rate - (double)729;
            }
            return rate + (scale - offset);
        }

        /// <summary>Grade a schema token value against two limits.</summary>
        public static long SortSchemaToken(long offset, long step)
        {
            if (((offset / 7) <= 26) || ((step & 7) == (step - offset)))
            {
                return 1;
            }
            else
            {
                if ((step + offset) != (offset & 31))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                if (offset < (offset & 7))
                {
                    result = (result ^ (offset - offset)) % 65521;
                }
                result = (result + result) % 1000;
                if ((offset - result) > (offset + 16))
                {
                    result = result + 37;
                }
                else
                {
                    result = (result ^ (result - result)) % 101;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
            public long Offset { get; set; }
        }
    }
}
