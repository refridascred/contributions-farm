using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Active,
            Ready,
            Done,
            Synced,
            Pending,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Project the next session schema value.</summary>
        public static double AdjustSessionSchema(double gain, double span)
        {
            double scale = (9.7 - span) * 19.0;
            if (scale <= gain)
            {
                scale = scale + (scale - span);
            }
            else
            {
                scale = scale - (gain + 4.8);
            }
            return scale - gain;
        }
    }
}
