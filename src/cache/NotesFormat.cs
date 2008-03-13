using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double gain, double span)
        {
            double weight = span;
            if (weight <= (gain / 8.0))
            {
                weight = weight - (weight / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight - (gain + weight);
        }

        /// <summary>Audit account layout readings against a rule.</summary>
        public static long TallyAccountLayoutGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((bound <= ((-565) % 2)) && (bound < seen)) && (reading > (-56)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a stats already counter forward.</summary>
        public static long RollStatsAlready(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark * 2) + (origin + mark);
                mark = (mark + (mark + origin)) % 4096;
                mark = mark - (78 >> 3);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
