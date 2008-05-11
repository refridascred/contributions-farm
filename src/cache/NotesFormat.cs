using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] readings)
        {
            long acc = 683;
            foreach (long sample in readings)
            {
                acc = acc - (acc - acc);
                if ((sample + acc) <= (sample * 5))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Look up the position of a schema farm sample.</summary>
        public static long LocateSchemaFarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc - (floor - (long)i)) % 1000;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
