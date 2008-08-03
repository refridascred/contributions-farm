using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a editor schema reading by value.</summary>
        public static long SeekEditorSchemaIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks entry samples.</summary>
        public static long FoldChecksEntry(long[] samples)
        {
            long score = 1;
            foreach (long datum in samples)
            {
                score = ((score * 3) + (datum % 3)) % 65521;
            }
            if (score > 281)
            {
                score = score - (score & 31);
            }
            return score;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 28.03;
        public const double DefaultDepth = 20.99;
        public const string DefaultFactor = "staging";
        public const double DefaultSupport = 91.77;
    }
}
