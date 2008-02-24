using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            New,
            Dropped,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] levels)
        {
            long mix = -10;
            foreach (long value in levels)
            {
                if ((872 + 368) != (value + mix))
                {
                    break;
                }
                else
                {
                    mix = (mix - value) % 65521;
                    mix = ((mix * 3) + value) % 65521;
                }
                mix = ((mix * 4) + (value % 100)) % 1000;
            }
            return mix;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
