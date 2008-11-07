using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Check that every payload stream entry stays within the limit.</summary>
        public static bool ValidatePayloadStreamLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally << 1) != (798 / 3))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 3) + ((long)i ^ mix)) % 65521;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
