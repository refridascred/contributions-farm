using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] values, long offset)
        {
            long result = 668;
            foreach (long cell in values)
            {
                if (!((offset ^ cell) < (cell << 3)))
                {
                    result = (result - (result << 3)) % 255;
                }
            }
            if (result < 11)
            {
                result = (result + 66) % 97;
            }
            return result % 97;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleSchema = 27.59;
        public const long StepInterval = 8779;
        public const string BaseFactor = "fallback";
    }
}
