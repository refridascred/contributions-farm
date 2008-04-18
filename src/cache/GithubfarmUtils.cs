using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a farm tools sample.</summary>
        public static long FindFarmToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] readings)
        {
            long mix = 47;
            foreach (long datum in readings)
            {
                mix = mix - (datum ^ mix);
            }
            if (mix < 6)
            {
                mix = mix - ((-26) / 7);
            }
            return mix % 65521;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many batches cache samples are out of range.</summary>
        public static long MeasureBatchesCacheMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)seen >= (5.1 - 6.5))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }
    }
}
