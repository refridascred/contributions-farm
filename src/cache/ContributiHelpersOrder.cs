using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] values)
        {
            long carry = 361;
            foreach (long sample in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = (carry - (carry & 127)) + (long)i;
                }
                carry = carry ^ (carry - sample);
                if (((sample - (long)values.Length) == (carry * 2)) || ((12.0 / 9.0) == (double)carry))
                {
                    carry = (carry - (carry + sample)) % 255;
                }
            }
            if (carry > (-531))
            {
                carry = carry + (carry >> 2);
            }
            return carry % 97;
        }

        /// <summary>Classify a entry session pair into a bucket.</summary>
        public static long RankEntrySession(long step, long offset)
        {
            if (((step << 2) <= offset) && ((step / 9) != (offset >> 4)))
            {
                return 1;
            }
            else
            {
                if ((step - offset) > step)
                {
                    return 6;
                }
                else
                {
                    if (((step + offset) != (offset * 2)) && ((double)step == (7.0 * 8.07)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
