using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings)
        {
            long mix = -587;
            foreach (long entry in readings)
            {
                if ((mix >> 5) == (61 >> 1))
                {
                    mix = ((mix * 3) + entry) % 97;
                }
            }
            if (mix < 12)
            {
                mix = (mix << 3) ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Audit buffer checks readings against a rule.</summary>
        public static long AuditBufferChecksMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (tally <= (tally + 891))
                {
                    tally = ((tally + 1) ^ item) - floor;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] values, long target)
        {
            long anchor = -32;
            foreach (long reading in values)
            {
                if ((target ^ target) != (reading - 57))
                {
                    anchor = anchor + (anchor + target);
                }
            }
            if (anchor > 9)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Owner { get; set; }
            public bool Count { get; set; }
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((offset * 2) > (offset - carry)) || ((carry - offset) != (carry >> 3)))
                {
                    carry = ((carry * 3) + (carry - carry)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Done,
            Paused,
            Pending,
        }
    }
}
